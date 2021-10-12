<script>
    export let click;
    export let icon;
</script>

<button class="button" on:click="{click}" >    
    <i class="{icon}"/>
</button>

<style>
    .button {
        padding:6px;
        background-color: transparent;
        color: red;
        margin: 5px;
        font-size: 22px;
        border: 0;
    }
</style>