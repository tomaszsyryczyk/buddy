<script>
    import Modal from "./../../controls/modal/modal.svelte";    
    import Button from "./../../controls/button/button.svelte";
    import History from "./history.svelte";
    import Current from "./current.svelte";

    let modalOpen = false;


    function openModal(){

    }

</script>

<Modal bind:isOpen={modalOpen}>

</Modal>

<div class="row end-xs">
    <div class="col-xs-1">
        <div class="box"><Button click={openModal} icon="fas fa-plus" />

        </div>
    </div>
</div>

<div class="row around-xs">
    <div class="col-xs-2">
        <div class="box">
            around
        </div>
    </div>
    <div class="col-xs-2">
        <div class="box">
            around
        </div>
    </div>
    <div class="col-xs-2">
        <div class="box">
            around
        </div>
    </div>
</div>

<div class="row center-xs">
    <div class="col-xs-10">
        <div class="box">
            <Current/>
            <History/>
        </div>
    </div>
</div>

<style>

</style>