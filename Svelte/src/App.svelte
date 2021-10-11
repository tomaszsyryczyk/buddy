<script>
	import { Router, Link, Route } from "svelte-navigator";
	import Home from "./routes/home/home.svelte";
	import Stocks from "./routes/stocks/stocks.svelte";
	import MenuItem from "./controls/menuitem/menuitem.svelte";

	function openNav() {
		var item = document.getElementById("sideNav");
		if(item)
			item.style.width = "250px";
  		document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
	}

	function closeNav() {		
		var item = document.getElementById("sideNav");	
		if(item)
			item.style.width = "0";
  		document.body.style.backgroundColor = "white";
	}
</script>

<Router>
	<nav id="sideNav" class="navigation">		
		<button style="background-color: transparent; border: 0;" class="closebtn" on:click="{closeNav}"><i class="far fa-times-circle" style="color: red;"></i></button>	
		<MenuItem click="{closeNav}" url="/" text="Home"/>
		<MenuItem click="{closeNav}" url="/stocks" text="Stocks"/>
		<MenuItem click="{closeNav}" url="/" text="nowy element listy dupa test"/>			
	</nav>
	<div class="content">
		<button on:click="{openNav}" ><i class="fas fa-align-justify"></i></button>
		<Route path="/">
			<Home />
		</Route>
		<Route path="/stocks" component={Stocks} />
		
	</div>
</Router>

<style>
	.navigation {
		height: 100%; /* 100% Full-height */
		width: 0; /* 0 width - change this with JavaScript */
		position: fixed; /* Stay in place */
		z-index: 1; /* Stay on top */
		top: 0; /* Stay at the top */
		left: 0;
		background-color: #111; /* Black*/
		overflow-x: hidden; /* Disable horizontal scroll */
		padding-top: 60px; /* Place content 60px from the top */
		transition: 0.5s; /* 0.5 second transition effect to slide in the sidenav */
	}

	.navigation .closebtn {
		position: absolute;
		top: 0;
		right: 25px;
		font-size: 36px;
		margin-left: 50px;
	}

	.content {
		width:auto;
	}
</style>
