<script>
</script>

<div class="main-bar">
    <div class="app-name">BUDDY</div>
    <div class="app-version">v.1.1.0</div>
    
    <div class="btn">
        <i class="far fa-window-minimize" />
    </div>
    <div class="btn">
        <i class="far fa-square" />
    </div>
    <div class="btn">
        <i class="fas fa-window-restore" />
    </div>
    <div class="btn btn-close ">
        <i class="fas fa-times" />
    </div>
</div>

<style>
    .main-bar {
        display: inline-grid;
        grid-template-columns: minmax(min-content, max-content) 1fr repeat(4, 3em);
        width: 100%;
        align-items: center;
        height: 2em;
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
