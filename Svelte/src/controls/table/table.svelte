<script>
    export let data = [];
    export let rowMappers = [];
</script>

<div class="table">
    <div class="header">
        {#each rowMappers as header}
            header name: {header.name}
        {/each}
    </div>
    <div class="content">
        {#each data as row}
            {#each rowMappers as getter}
                name: {getter.getValue()}
            {/each}
        {/each}
    </div>
asdf
    <div class="footer"></div>
</div>
<style>

</style>
