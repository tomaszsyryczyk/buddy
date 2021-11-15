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

    function rowMapper(){
        return [
            new column('Nazwa', (row) => row.name),
            new column('Ilość', (row) => row.count),
            new column('zł/akcja', (row) => row.price),
            new column('Marża', (row) => row.fee),
        ]

    }

    function column(name, getValue){
        return {
            name:name,
            getValue: getValue
        }
    }

</script>

<AddStockModal bind:modalOpen={modalOpen} />

<Stocks>
    <Table data={currentStocks} rowMappers={rowMapper()} />    
</Stocks>


<style>

</style>