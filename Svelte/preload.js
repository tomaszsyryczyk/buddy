const { contextBridge, ipcRenderer } = require("electron");

contextBridge.exposeInMainWorld('electron', {
    close: close,
    minimalize: minimalize,
    maxUnmax: maxUnmax
});

function close() {
    ipcRenderer.invoke('close-window');
}

function minimalize(){
    ipcRenderer.invoke('minimize-window');
}

function maxUnmax() {
    let result = ipcRenderer.invoke('maxUnmax-window');
    return result;
}