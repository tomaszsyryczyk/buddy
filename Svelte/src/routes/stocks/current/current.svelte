<script>    
    import { onMount } from "svelte";
    import Stocks from "./../stocks.svelte";
    import AddStockModal from "./../addStockModal/addStockModal.svelte";
    import Table from "./../../../controls/table/table.svelte";
    let currentStocks = [];

    //let columnNames = ['Name', 'Ilość', 'zł/akcja', 'Marża', 'Data', 'na 0', 'Aktualna', '%', 'Sprzedaż', 'Zysk'];

    // function mapper(data){
    //     return [data.name, data.count,data.price, data.fee, data.data, data.equal, data.current,data.delta, data.sell, data.income];
    // };

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

    function column(name, getValue){
        return {
            columnName: name,
            columnValue: getValue
        }
    }

</script>

<AddStockModal bind:modalOpen={modalOpen} />

<Stocks>
    <Table rows={currentStocks} rowMappers={mappers()} />    
</Stocks>


<style>

</style>