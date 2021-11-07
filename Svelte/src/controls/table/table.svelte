<script>
    export let data = [];
    export let rowMappers = [];
</script>

{#each data as row}
    {#each rowMappers as rowMapper}
                name: {rowMapper.name} | value: {rowMapper.getValue(row)} <br/>
            {/each}   
           {/each}   
<!-- <div class="row">
             <div class="col-xs-offset-11 col-xs-1">
                     <div class="box btn">
                          <Button click={toggleModal} icon="fas fa-plus" />
                        </div>
                   </div>
              </div>
          <div class="table">
          <Header values="{columnNames}"/>     
           {#each currentStocks as row}
              <Row data="{row}" mapper={mapper} />
           {/each}   
        </div> -->
<style>

</style>