<script>
    import MenuItem from "./menuitem.svelte";
	import CloseButton from "./../controls/button/closeButton.svelte";
    function closeNav() {		
		var item = document.getElementsByClassName("navigation-container")[0];	
		if(item)
			item.style.width = "0";
	}
</script>

<div class="navigation-container">
    <nav class="navigation">		
		<CloseButton icon="far fa-times-circle" click="{closeNav}"/>
        <MenuItem icon="fas fa-home" click="{closeNav}" url="#" text="Home"/>
        <MenuItem click="{closeNav}" url="#/stocks" text="Stocks"/>
        <MenuItem click="{closeNav}" url="/" text="nowy element listy dupa test"/>			
    </nav>
</div>

<style>
    .navigation-container {
		height: 100%; /* 100% Full-height */
		width: 0; /* 0 width - change this with JavaScript */
		position: fixed; /* Stay in place */
		z-index: 1; /* Stay on top */
		top: 0; /* Stay at the top */
		left: 0;
		background-color: rgb(187, 184, 184); 
		overflow-x: hidden; /* Disable horizontal scroll */
		padding-top: 60px; /* Place content 60px from the top */
		transition: 0.5s; /* 0.5 second transition effect to slide in the sidenav */
	}	
</style>