<script>
    export let click;
    export let icon;
    export let text;
    export let error;
    $: className = error? "btn-secondary" : "btn-primary";
</script>

<button class="btn {className}" on:click="{click}" >    
    {#if icon}
    <i class="{icon}"/>
    {/if}
    {#if text}
        {text}
    {/if}
</button>

<style>

    .btn-primary{
        background-color: var(--primary-color);
    }

    .btn-secondary{
        background-color: var(--secondary-color);
    }

    .btn {
        padding:0.3em 0.4em;
        color: white;
        margin: 5px;
        font-size: 1.3em;
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