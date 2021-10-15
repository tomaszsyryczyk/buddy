<script>    
    import Header from "./currentheader.svelte";
    import Row from "./currentrow.svelte";
    import Stocks from "./../stocks.svelte";
    let data;
    // var key = "stocks-current";
    // function getData(){
    //     data = localStorage.getItem(key);
    // };
    // getData();

    data = [{name: 'CDR', count: '5', price: '172,5', fee: '5', value: '867,5', data: '', equal: '174,5', current: '190', delta: '8,88', sell: '945', income: '77,5'},
            {name: 'KGHM', count: '5', price: '', fee: '', value: '', data: '', equal: '', current: '', delta: '-10', sell: '', income: ''},
            {name: 'PKOBP', count: '30', price: '', fee: '', value: '', data: '', equal: '', current: '', delta: '0,00', sell: '', income: ''},
            {name: 'PZU', count: '36', price: '', fee: '', value: '', data: '', equal: '', current: '', delta: '0', sell: '', income: ''},
            {name: 'PZU', count: '50', price: '', fee: '', value: '', data: '', equal: '', current: '', delta: '', sell: '', income: ''}];

    let columnNames = ['Name', 'Ilość', 'zł/akcja', 'Marża', 'Data', 'na 0', 'Aktualna', '%', 'Sprzedaż', 'Zysk'];

    function mapper(data){
        return [data.name, data.count,data.price, data.fee, data.data, data.equal, data.current,data.delta, data.sell, data.income];
    };

</script>

<Stocks>
    <div class="table">
        <Header values="{columnNames}"/>     
        {#each data as row}
            <Row data="{row}" mapper={mapper} />
        {/each}   
    </div>
</Stocks>


<style>
  .table {
  display: flex;
  flex-flow: column nowrap;
  font-size: .8rem;
  margin: 0.5rem;
  line-height: 1.5;
  border-bottom: 1px solid #d0d0d0;
  flex: 1 1 auto;
  }

</style>