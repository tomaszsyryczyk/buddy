<script>
    export let data = [];
    export let rowMappers = [];
</script>

{#each data as row}
    {#each rowMappers as rowMapper}
                name: {rowMapper.name} | value: {rowMapper.getValue(row)} <br/>
            {/each}   
           {/each}   

<style>

</style>