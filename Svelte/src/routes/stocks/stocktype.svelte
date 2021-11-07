<script>
    import { link } from "svelte-spa-router";
    export let text;
    export let url;
</script>

<a href={url} use:link={{ disabled: false }} class="link" >
    <input type="button" value="{text}" class="btn"/>
</a>

<style>
    .btn {
        padding: 6px 20px;
        margin: 10px;
        background-color: var(--secondary-color);
        color: white;
        border: 0;
        -webkit-box-shadow: var(--box-shadow);
        -moz-box-shadow: var(--box-shadow);
        box-shadow: var(--box-shadow);
        border-radius: 25px;
    }

    .btn:hover {
        background-color: var(--secondary-color-shadow);
    }

    .btn:active {
        transform: scale(0.98);
        box-shadow: var(--box-shadow-active);
    }
</style>
