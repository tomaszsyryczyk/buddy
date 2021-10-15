<script>
    export let click;
    export let icon;
</script>

<button class="btn" on:click="{click}" >    
    <i class="{icon}"/>
</button>

<style>
    .btn {
        padding:0.5em 0.6em;
        background-color: var(--primary-color);
        color: white;
        margin: 5px;
        font-size: 22px;
        border: 0;
        border-radius: 0.3em;
        
        -webkit-box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 0.55);
        -moz-box-shadow: 2px 2px 5px 0px rgba(0, 0, 0,  0.55);
        box-shadow: 2px 2px 5px 0px rgba(0, 0, 0,  0.55);     
    }

    .butbtnton:hover {
        background-color: var(--primary-color-shadow)    
    }

    .btn:active {
            transform: scale(0.98);
            box-shadow: var(--box-shadow-active);
    }
</style>