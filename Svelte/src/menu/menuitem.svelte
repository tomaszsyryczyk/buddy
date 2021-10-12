<script>
    import {link} from 'svelte-spa-router';
    export let url;
    export let click;
    export let text;
    export let icon;

    function safeFunction(){
        if(click)
            click();
    }
</script>

<a href="{url}" on:click="{safeFunction}" use:link={{disabled: false}}>
    <div class="row">
        <div class="{icon} icon"></div>
        <div class="content">{text}</div>
    </div>
</a>

<style>
    .row {        
        align-items: stretch;
        align-content: stretch;
        align-content: center;
        padding: 10px;
    }

    .row:hover {
        background-color: pink;
    }

    .content {
        margin: auto 0;
        width: 80%;
    }

    .icon {
        width: 20%;
        margin: auto 0;
        height: 1.5em;
    }
    
</style>