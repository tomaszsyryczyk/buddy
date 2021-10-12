<script>
    import Modal from "./../../controls/modal/modal.svelte";    
    let data;
    let modalOpen = false;



    var key = "currentstocks";
    function getData(){
        data = localStorage.getItem(key);
    }

</script>

<Modal bind:isOpen={modalOpen}>

</Modal>

<div class="row">

</div>
<div class="row">
    asd
</div>

<style>

</style>