<script>
    export let text;
    export let click;
</script>


<button class="btn" on:click="{click}" >{text}</button>

<style>
    .btn {
        padding: 6px 20px;
        background-color: red;
        color: white;
        border: 0;
        -webkit-box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 1);
        -moz-box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 1);
        box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 1);        
        border-radius: 25px;
    }

    .btn:hover {
        background-color: royalblue;
    }

    .btn:active {
            transform: scale(0.98);
            box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 0.24);
    }

</style>