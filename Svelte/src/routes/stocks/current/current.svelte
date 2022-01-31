<script>    
    import { onMount } from "svelte";
    import Stocks from "./../stocks.svelte";
    import AddStockModal from "./../addStockModal/addStockModal.svelte";
    import Table, { column } from "./../../../controls/table/table.svelte";
    let currentStocks = [];

    onMount(async () => {
        axios('https://localhost:5001/api/stocks/current')
            .then(function (response) {
                currentStocks = response.data;
            });
    })

    let modalOpen = false;

    function mappers(){
        return [
            new column('Nazwa', (row) => row.name),
            new column('Ilość', (row) => row.count),
            new column('zł/akcja', (row) => row.price),
            new column('Marża', (row) => row.fee),
            new column('Test', (row) => "<div class=\"test\">does it work?</div>"),
        ]
    }

</script>

<AddStockModal bind:modalOpen={modalOpen} />

<Stocks>
    <Table rows={currentStocks} rowMappers={mappers()} />    
</Stocks>


<style>

</style>