// Native
import { join } from 'path';
import { spawn, ChildProcessWithoutNullStreams } from 'child_process';

// Packages
import { BrowserWindow, app, ipcMain, IpcMainEvent } from 'electron';
import isDev from 'electron-is-dev';

let DJANGO_CHILD_PROCESS: ChildProcessWithoutNullStreams ;

if (require('electron-squirrel-startup')) {
  // eslint-disable-line global-require
  app.quit();
}

const height = 600;
const width = 800;

const spawnDjango = () =>
{
  if ( isDevelopmentEnv() )
  {
    return spawn(`python\\venv\\Scripts\\python.exe`,
      ['python\\backend\\manage.py', 'runserver', '--noreload'], {
        shell: true,
      });
  }
  return spawn(`cd backend && api.exe runserver --settings=app.settings.prod --noreload`,  {
    shell: true,
  });
}

const isDevelopmentEnv = () => {
  console.log( `NODE_ENV=${ process.env.NODE_ENV }` )
  return process.env.NODE_ENV == 'development'
}

const UpsertKeyValue = (obj : any, keyToChange : string, value : string[]) => {
  const keyToChangeLower = keyToChange.toLowerCase();
  for (const key of Object.keys(obj)) {
    if (key.toLowerCase() === keyToChangeLower) {
      // Reassign old key
      obj[key] = value;
      // Done
      return;
    }
  }
  // Insert at end instead
  obj[keyToChange] = value;
}

const startDjangoServer = () => 
{
  DJANGO_CHILD_PROCESS = spawnDjango();
  DJANGO_CHILD_PROCESS.stdout.on('data', data =>
  {
    console.log(`stdout:\n${data}`);
  });
  DJANGO_CHILD_PROCESS.stderr.on('data', data =>
  {
    console.log(`stderr: ${data}`);
  });
  DJANGO_CHILD_PROCESS.on('error', (error) =>
  {
    console.log(`error: ${error.message}`);
  });
  DJANGO_CHILD_PROCESS.on('close', (code) =>
  {
    console.log(`child process exited with code ${code}`);
  });
  DJANGO_CHILD_PROCESS.on('message', (message) =>
  {
    console.log(`message:\n${message}`);
  });
  return DJANGO_CHILD_PROCESS;
}

function createWindow() {
  // Create the browser window.
  const window = new BrowserWindow({
    width,
    height,
    //  change to false to use AppBar
    frame: false,
    show: true,
    resizable: true,
    fullscreenable: true,
    webPreferences: {
      preload: join(__dirname, 'preload.js')
    }
  });
  startDjangoServer()
  window.webContents.session.webRequest.onBeforeSendHeaders(
    (details, callback) => {
      const { requestHeaders } = details;
      UpsertKeyValue(requestHeaders, 'Access-Control-Allow-Origin', ['*']);
      callback({ requestHeaders });
    },
  );

  window.webContents.session.webRequest.onHeadersReceived((details, callback) => {
    const { responseHeaders } = details;
    UpsertKeyValue(responseHeaders, 'Access-Control-Allow-Origin', ['*']);
    UpsertKeyValue(responseHeaders, 'Access-Control-Allow-Headers', ['*']);
    callback({
      responseHeaders,
    });
  });

  const port = process.env.PORT || 3000;
  const url = isDev ? `http://localhost:${port}` : join(__dirname, '../src/out/index.html');

  // and load the index.html of the app.
  if (isDev) {
    window?.loadURL(url);
  } else {
    window?.loadFile(url);
  }
  // Open the DevTools.
  // window.webContents.openDevTools();

  // For AppBar
  ipcMain.on('minimize', () => {
    // eslint-disable-next-line no-unused-expressions
    window.isMinimized() ? window.restore() : window.minimize();
    // or alternatively: win.isVisible() ? win.hide() : win.show()
  });
  ipcMain.on('maximize', () => {
    // eslint-disable-next-line no-unused-expressions
    window.isMaximized() ? window.restore() : window.maximize();
  });

  ipcMain.on('close', () => {
    window.close();
  });
}
// This method will be called when Electron has finished
// initialization and is ready to create browser windows.
// Some APIs can only be used after this event occurs.
app.whenReady().then(() => {
  createWindow();

  app.on('activate', () => {
    // On macOS it's common to re-create a window in the app when the
    // dock icon is clicked and there are no other windows open.
    if (BrowserWindow.getAllWindows().length === 0) createWindow();
  });
});

// Quit when all windows are closed, except on macOS. There, it's common
// for applications and their menu bar to stay active until the user quits
// explicitly with Cmd + Q.
app.on('window-all-closed', () => {
  app.quit();
  DJANGO_CHILD_PROCESS.kill();
});

// In this file you can include the rest of your app's specific main process
// code. You can also put them in separate files and require them here.

// listen the channel `message` and resend the received message to the renderer process
ipcMain.on('message', (event: IpcMainEvent, message: any) => {
  console.log(message);
  setTimeout(() => event.sender.send('message', 'hi from electron'), 500);
});
