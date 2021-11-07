const { remote } = require("electron");

function getCurrentWindow() {
    return remote.getCurrentWindow();
}

function minimizeWindow(browserWindow = getCurrentWindow()) {
    if (browserWindow.minimizable) {
        // browserWindow.isMinimizable() for old electron versions
        browserWindow.minimize();
    }
}

function maximizeWindow(browserWindow = getCurrentWindow()) {
    if (browserWindow.maximizable) {
        // browserWindow.isMaximizable() for old electron versions
        browserWindow.maximize();
    }
}

function unmaximizeWindow(browserWindow = getCurrentWindow()) {
    browserWindow.unmaximize();
}

function maxUnmaxWindow(browserWindow = getCurrentWindow()) {
    if (browserWindow.isMaximized()) {
        browserWindow.unmaximize();
    } else {
        browserWindow.maximize();
    }
}

function closeWindow(browserWindow = getCurrentWindow()) {
    browserWindow.close();
}

function isWindowMaximized(browserWindow = getCurrentWindow()) {
    return browserWindow.isMaximized();
}

window.addEventListener("DOMContentLoaded", () => {
    window.getCurrentWindow = getCurrentWindow;
    window.minimizeWindow = minimizeWindow;
    window.unmaximizeWindow = unmaximizeWindow;
    window.maxUnmaxWindow = maxUnmaxWindow;
    window.isWindowMaximized = isWindowMaximized;
    window.closeWindow = closeWindow;
    window.test = "its working";
});

window.test2 = "its working2";
debugger;