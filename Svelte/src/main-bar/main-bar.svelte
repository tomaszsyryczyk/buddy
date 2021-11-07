<script>
    function minimizeWindow() {
        window.electron.minimalize();
    }

    function maxUnmaxWindow() {
        isWindowMaximized = window.electron.maxUnmax();
    }

    function closeWindow(){
        window.electron.close();
    } 

    let isWindowMaximized = false;

    $: maxUnmaxClass = isWindowMaximized? "fa-window-restore": "fa-square";
</script>

<div class="main-bar">
    <div class="app-name">BUDDY</div>
    <div class="app-version">v.1.1.0</div>
    <div />
    <div class="btn" on:click="{minimizeWindow}">
        <i class="far fa-window-minimize" />
    </div>
    <div class="btn" on:click="{maxUnmaxWindow}">
        <i class="far {maxUnmaxClass}" />
    </div>
    <div class="btn btn-close" on:click="{closeWindow}">
        <i class="fas fa-times" />
    </div>
</div>

<style>
    .main-bar {
        display: inline-grid;
        grid-template-columns: repeat(2, minmax(min-content, max-content)) 1fr repeat(
                3,
                3em
            );
        width: 100%;
        align-items: center;
        height: 2em;
        -webkit-user-select: none;
        -webkit-app-region: drag;
    }

    .app-name {
        color: #e91e63;
        font-size: 1rem;
        letter-spacing: 0.2em;
        text-transform: uppercase;
        font-weight: 700;
        margin-left: 1em;
    }

    .app-version {
        color: gray;
        font-size: 0.85rem;
        margin: 5px;
    }

    .btn {
        -webkit-app-region: no-drag;
        background-color: transparent;
        cursor: pointer;
        height: 2em;
        display: table;
        text-align: center;
    }

    .btn > i {
        display: table-cell;
        vertical-align: middle;
    }

    .btn:hover {
        background-color: gray;
    }

    .btn-close:hover {
        background-color: brown;
    }
</style>
