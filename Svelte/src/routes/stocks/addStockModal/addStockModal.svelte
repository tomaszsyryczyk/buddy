<script>
    import Modal from "./../../../controls/modal/modal.svelte";   
    import InputNumber from "./../../../controls/input/inputNumber.svelte";
    import InputString from "./../../../controls/input/inputString.svelte";
    import InputDate from "./../../../controls/input/inputDate.svelte";
    import InputEnum from "./../../../controls/input/inputEnum.svelte";
    

    export let modalOpen = false;
    let data = {
            name: '',
            count: 0,
            price: 0.0,
            type: 0,
            fee: 0.0,
            when: ''
        };;

    function toggleModal(){
        clearModal();
        modalOpen = !modalOpen;
    }

    function clearModal(){
        data = {
            name: '',
            count: 0,
            price: 0.0,
            type: 0,
            fee: 0.0,
            when: ''
        };
    }

    function saveStocks(){
        var toSave = data;
        postData(toSave);
        toggleModal();
    }

    function postData(data){
        axios({
            method: 'post',
            url: 'https://localhost:5001/api/stocks',
            data: data
            })  
            .then(function(response){
                console.log(response);
            });
    }
</script>

<Modal bind:isOpen={modalOpen} success={saveStocks}>
    <div class="form box center-xs">
        {#if data}
            <InputString bind:value={data.name} name="name" /> 
            <InputNumber bind:value={data.count} name="count"/>
            <InputNumber bind:value={data.price} name="price"/>
            <InputEnum bind:value={data.type} name="type"/>
            <InputNumber bind:value={data.fee} name="fee"/>
            <InputDate bind:value={data.when} name="when"/>
        {/if}
    </div>
</Modal>

<style>
    .form {
        padding: 0.2em;
    }

</style>