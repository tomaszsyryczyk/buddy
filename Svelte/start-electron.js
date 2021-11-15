const { app, BrowserWindow, screen, ipcMain, Menu, Tray } = require('electron');
const path = require("path");
require('electron-reload')(app.getAppPath());

function createTray() {
    let appIcon = new Tray(path.join(app.getAppPath(), "./public/favicon.ico"));
    const contextMenu = Menu.buildFromTemplate([
        {
            label: 'Show', click: function () {
                window.show();
            }
        },
        {
            label: 'Exit', click: function () {
                app.isQuiting = true;
                app.quit();
            }
        }
    ]);

    appIcon.on('double-click', function (event) {
        window.show();
    });
    appIcon.setToolTip('Tray Tutorial');
    appIcon.setContextMenu(contextMenu);
    return appIcon;
}

ipcMain.handle('close-window', (event, ...args) => {
    window.close();
})

ipcMain.handle('minimize-window', (event, ...args) => {
    debugger;
    window.minimize();
})

ipcMain.handle('maxUnmax-window', (event, ...args) => {
    debugger;
    let isMaxed = window.isMaximized();
    if (isMaxed)
        window.unmaximize();
    else
        window.maximize();

    return isMaxed;
})

const createWindow = () => {
    const { width, height } = screen.getPrimaryDisplay().workAreaSize;

    window = new BrowserWindow({
        width: width / 1.25,
        height: height / 1.25,
        webPreferences: {
            preload: path.join(app.getAppPath(), "preload.js"),
            nableRemoteModule: false,
            contextIsolation: true
        },
        frame: false
    });

    window.maximize();

    window.loadFile('public/index.html');

    window.on('closed', function () {
        debugger;
        windows = null;
    });

    let tray = null;
    window.on('minimize', function (event) {
        event.preventDefault();
        window.hide();
        tray = createTray();
    });

    window.on('restore', function (event) {
        window.show();
        tray.destroy();
    });
};

let window = null;

app.whenReady().then(createWindow)
app.on('window-all-closed', () => app.quit());

// in your main process, having Electron's `app` imported
app.on ("certificate-error", (event, webContents, url, error, cert, callback) => {
     callback (true);     
});

