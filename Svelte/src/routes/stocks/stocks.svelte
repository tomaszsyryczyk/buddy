<script> 
    import StockType from "./stocktype.svelte";
</script>




<div class="row around-xs">
    <div class="col-xs-4">
        <div class="box">
            <div class="row around-xs">
                <div class="col-xs-1">
                    <div class="box">
                        <StockType text="Current" url="/stocks/current"/>
                    </div>
                </div>
                <div class="col-xs-1">
                    <div class="box">
                        <StockType text="History" url="/stocks/history"/>
                    </div>
                </div>               
            </div>
        </div>
    </div>
</div>


<div class="row center-xs table">
    <div class="col-xs-10">
        <div class="box">
            <slot>
            </slot>      
        </div>
    </div>
</div>

<style>
   

    .table {
        padding-top: 1em;
    }
</style>