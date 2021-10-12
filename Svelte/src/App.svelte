<script>
	import { Router, Link, Route } from "svelte-navigator";
	import Home from "./routes/home/home.svelte";
	import Stocks from "./routes/stocks/stocks.svelte";
	import Menu from "./menu/menu.svelte";
	import Button from "./controls/button/button.svelte"

	function openNav() {
		var item = document.getElementsByClassName("navigation-container")[0];
		if(item)
			item.style.width = "20%";
	}	
</script>

<Router>
	<Menu />
	
	<div class="top-panel debug">
		<Button icon="fas fa-align-justify" click="{openNav}"/>
	</div>

	<div class="content debug">		
		<Route path="#/">
			<Home />
		</Route>
		<Route path="#/stocks" component={Stocks} />
		<Route path="/#" component={Home} />
		
	</div>
</Router>

<style>
	.debug {
		border: 3px solid #000;;
	}	

	.content {
		width:90%;
		margin: auto;
		align-self: center;
	}
</style>
