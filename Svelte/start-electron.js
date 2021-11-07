const { app, BrowserWindow, screen } = require('electron');
const path = require("path");
require('electron-reload')(app.getAppPath());


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

    window.loadFile('public/index.html');
};

let window = null;

app.whenReady().then(createWindow)
app.on('window-all-closed', () => app.quit());