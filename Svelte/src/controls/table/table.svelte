<script context="module">
    export function column(name, getValue, getSummary) {
        return {
            columnName: name,
            columnValue: getValue,
            columnSummary: getSummary
        };
    }
</script>

<script>
    export let rows = [];
    export let rowMappers = [];
    let summary = [];
</script>

<div class="table">
    <div class="header">
        {#each rowMappers as header}
            <div class="header-cell">
                {header.columnName}
            </div>
        {/each}
    </div>
    {#each rows as row}
        <div class="content-row">
            {#each rowMappers as mapper}
                <div class="content-cell">
                    {@html mapper.columnValue(row)}
                </div>
            {/each}
        </div>
    {/each}

    <div class="footer">
        
        {#each rowMappers as mapper}
            <div class="header-cell">
                {#if mapper.columnSummary}
                    {mapper.columnSummary()}
                {/if}
            </div>
        {/each}
    </div>
</div>

<style>
    .table {
        border: 0;
        display: table;
        margin: 1em;
        padding: 0.5em;
        width: 100%;
    }

    .header {
        border: 0;
        width: 100%;
        display: table-row;
    }

    .header-cell {
        background-color: #393939;
        display: table-cell;
        color: #00ad5f;
        padding: 1em;
    }

    .header :first-child {
        border-radius: 0.5em 0 0 0;
    }

    .header :last-child {
        border-radius: 0 0.5em 0 0;
    }

    .content-row {
        background-color: #222222;
        display: table-row;
        padding: 1em;
        color: #808080;
    }

    .content-row:hover {
        color: pink;
    }

    .content-cell {
        display: table-cell;
        padding: 1em;
    }

    .footer {
        background-color: #222222;
        padding: 1em;
        min-height: 1em;
        border: 0;
        width: 100%;
        display: table-row;
    }

    .footer :first-child {
        border-radius: 0 0 0 0.5em;
    }

    .footer :last-child {
        border-radius: 0 0 0.5em 0;
    }
</style>
