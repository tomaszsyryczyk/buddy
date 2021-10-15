<script>    
    import Stocks from "./../stocks.svelte";
    let data;
    var key = "stocks-history";
    function getData(){
        data = localStorage.getItem(key);
    }
    getData();
</script>


<Stocks>
  
test history {data}

</Stocks>
