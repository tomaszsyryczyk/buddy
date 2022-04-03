<script context="module">
	export function menuItem(name, url, icon) {
		var self = this;
		self.name = name;
		self.url = url;
		self.icon = icon;
	}
</script>

<script>
	import { link } from "svelte-spa-router";
	export let menus;
	import { apiModule } from "./../api-access/api.svelte";
	import Accordion, { Panel, Header, Content } from "@smui-extra/accordion";

	apiModule.getSimpleData();
</script>

{#each menus as menu}
	<a href={menu.url} class="url" use:link={{ disabled: false }}>
		<div class="row start-xs menu-item">
			<Accordion>
				<Panel>
					<Header>
						<div class="fas {menu.icon}">{menu.name}</div></Header
					>
				</Panel>
			</Accordion>
		</div>
	</a>
{/each}


<style>
	
</style>