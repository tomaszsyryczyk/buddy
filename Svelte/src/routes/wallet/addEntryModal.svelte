<script>
    import Modal from "./../../controls/modal/modal.svelte";   
    import InputNumber from "./../../controls/input/inputNumber.svelte";
    import InputString from "./../../controls/input/inputString.svelte";
    import InputDate from "./../../controls/input/inputDate.svelte";
    import InputEnum from "./../../controls/input/inputEnum.svelte";  
    import {getWalletEntryTypes} from "./walletConsts.svelte";  

    function clearModal(){
        var current = new Date();
        data = {
            type: 0,
            name: '1',
            value: 0.0,
            when: current.toJSON()
        };
    }

    var enumTypes = getWalletEntryTypes();

    function toggleModal(){
        clearModal();
        modalOpen = !modalOpen;
    }
    
    let data =  {};
    clearModal();

    export let modalOpen = false;  

    function saveEntry(){
        var toSave = data;
        postData(toSave);
        toggleModal();
    }

    function postData(data){
        axios({
            method: 'post',
            url: 'https://localhost:5001/api/wallet',
            data: data
            })  
            .then(function(response){
                console.log(response);
            });
    }
</script>

<Modal bind:isOpen={modalOpen} success={saveEntry}>
    <div class="form box center-xs">
        {#if data}
            <InputEnum startingValue={2} types={enumTypes} bind:value={data.type} name="type" /> 
            <InputString bind:value={data.name} name="name"/>
            <InputNumber bind:value={data.value} name="value"/>
            <InputDate bind:value={data.when} name="when"/>
        {/if}
    </div>
</Modal>

<style>
    .form {
        padding: 0.2em;
    }

</style>
