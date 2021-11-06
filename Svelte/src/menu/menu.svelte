<script>
	import {link} from 'svelte-spa-router';
	export let menus;

	function toggleNav(){
		openNav = !openNav;
	}

	let openNav = false;
    $: navBtnClassName = openNav? "fa-times": "fa-bars";
	$: extendedClassName = openNav? "nav-main-ext": "nav-main-short";
	$: extClassName = openNav? "menu-item-ext": "menu-item-short";
	$: hidden = openNav? "show" : "hidden";
	
</script>

<div class="nav-main {extendedClassName}">
	<div id="nav-button" class="menu-item row start-xs" on:click="{toggleNav}">
		<div>
			<div class="fas {navBtnClassName}"></div>
		</div>		
		<div class="description {hidden}">
			MENU
		</div>
	</div>

	{#each menus as menu}
		<a href="{menu.url}" class="url"  use:link={{disabled: false}}>
			<div class="row start-xs menu-item">
				<div class="{extClassName}" >
					<div class="fas {menu.icon}"></div>
				</div>
				<div class="description {hidden} ">
					{menu.name}
				</div>
			</div>
		</a>
	{/each}
</div>

<style>		
	@keyframes fade-in {
	from {
		opacity: 0;
	}
	to {
		opacity: 1;
	}
	}

	@keyframes fade-out {
	from {
		opacity: 1;
	}
	to {
		opacity: 0;
	}
	}
	.show {
		animation: fade-in 1s;
	}

	.hidden {
		display: none;
		animation: fade-out 1s;
	}

	.description {
		padding-left: 2em;
	}

	#nav-button {
		background-color: #2e8364;
		color: #393939;
	}

	.nav-main-ext {
		width: 15em;
	}

	.nav-main-short {
		width: 5em;
	}

	.nav-main {
		position: fixed;
		height: 100%;
		top: 0;
		left: 0;
		background-color: #222222;
		padding: 0;
		transition: width 0.5s;
	}	

	.menu-item {
		margin: auto;
		padding: 1em;
		color: #aaaaaa;
		text-align: center;
		font-size: 1.5em;
	}

	
	.menu-item:hover {
		background-color: #393939;
		color: #2e8364;
	}

    
</style>