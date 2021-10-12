<script>
    import Modal from "./../../controls/modal/modal.svelte";    
    import Button from "./../../controls/button/button.svelte";
    import History from "./history/history.svelte";
    import Current from "./current/current.svelte";
    import StockType from "./stocktype.svelte";

    let modalOpen = false;
    let option = 1;

    function addModal(){

    }

    function openCurrent(){
        option = 1;
    }

    function openHistory(){
        option = 2;
    }

</script>

<Modal bind:isOpen={modalOpen}>

</Modal>

<div class="row">
    <div class="col-xs-offset-11 col-xs-1">
        <div class="box btn">
            <Button click={addModal} icon="fas fa-plus" />
        </div>
    </div>
</div>
<div class="row around-xs">
    <div class="col-xs-4">
        <div class="box">
            <div class="row around-xs">
                <div class="col-xs-1">
                    <div class="box">
                        <StockType text="Current" click="{openCurrent}"/>
                    </div>
                </div>
                <div class="col-xs-1">
                    <div class="box">
                        <StockType text="History" click="{openHistory}"/>
                    </div>
                </div>               
            </div>
        </div>
    </div>
</div>


<div class="row center-xs">
    <div class="col-xs-10">
        <div class="box">
            {#if option == 1}
                <Current/>
            {/if}

            {#if option == 2}
                <History/>
            {/if}
        </div>
    </div>
</div>

<style>
    .btn {
        justify-content: flex-start;
    }
</style>