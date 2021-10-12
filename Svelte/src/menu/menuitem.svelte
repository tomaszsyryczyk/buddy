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
    <div class="row menu-item">
        <div class="{icon} icon"></div>
        <div class="content">{text}</div>
    </div>
</a>

<style>  
    .menu-item{
        padding: 5px;;
    }

    .menu-item:hover {
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