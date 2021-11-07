<script>
    export let click;
    export let icon;
    export let text = "";
    import Button from "./button.svelte";
</script>

<button class="btn" on:click={click}>
    {#if icon}
        <i class={icon} />
    {/if}
    {#if text}
        {text}
    {/if}
</button>

<style>
    .btn {
        background-color: var(--secondary-color);
        padding: 0.3em 0.4em;
        color: white;
        margin: 5px;
        font-size: 1.3em;
        border: 0;
        border-radius: 0.3em;

        -webkit-box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 0.55);
        -moz-box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 0.55);
        box-shadow: 2px 2px 5px 0px rgba(0, 0, 0, 0.55);
    }

    .btn:hover {
        background-color: var(--secondary-color-shadow);
    }

    .btn:active {
        transform: scale(0.98);
        box-shadow: var(--box-shadow-active);
    }
</style>
