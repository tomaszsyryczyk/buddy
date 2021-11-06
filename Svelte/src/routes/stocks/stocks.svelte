<script>
    import StockType from "./stocktype.svelte";
</script>

<div class="stocks">
    <div class="stock-types">
        <div></div>
        <StockType text="Current" url="/stocks/current" />
        <StockType text="History" url="/stocks/history" />       
    </div>
    <div class="stock-content">
        <slot />
    </div>
</div>


<style>
    .stocks {
        display: grid;
		grid-gap: 1em;
		grid-template-columns: 1fr;
        grid-auto-rows: minmax(min-content, max-content);
		margin: 0;
		height: 100%;
    }

    .stock-types{
        place-self: center
    }
</style>
