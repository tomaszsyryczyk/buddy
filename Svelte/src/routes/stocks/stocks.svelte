<script> 
    import Button from "./../../controls/button/button.svelte";
    import StockType from "./stocktype.svelte";
    import AddStockModal from "./addStockModal/addStockModal.svelte";

    let modalOpen = false;

    function toggleModal(){
        modalOpen = !modalOpen;
    }


</script>

<AddStockModal bind:modalOpen={modalOpen} />

<div class="row">
    <div class="col-xs-offset-11 col-xs-1">
        <div class="box btn">
            <Button click={toggleModal} icon="fas fa-plus" />
        </div>
    </div>
</div>
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
    .btn {
        justify-content: flex-start;
    }

    .table {
        padding-top: 1em;
    }
</style>