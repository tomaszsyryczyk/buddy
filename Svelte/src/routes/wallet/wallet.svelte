<script lang="ts">
    import Tab, { Icon, Label } from "@smui/tab";
    import TabBar from "@smui/tab-bar";
    import Settings from "./settings.svelte";
    import Summary from "./summary.svelte";
    import History from "./hisotry.svelte";
    let tabs = [
        {
            icon: "analytics",
            label: "Podsumowanie",
            id: 2,
        }, 
        {
            icon: "history",
            label: "Historia",
            id: 1,
        }, 
        {
            icon: "settings",
            label: "Ustawienia",
            id: 0,
        },
       
    ];
    $: active = tabs[0];
</script>

<div>
    <TabBar {tabs} let:tab bind:active>
        <Tab {tab}>
            <Icon class="material-icons">{tab.icon}</Icon>
            <Label>{tab.label}</Label>
        </Tab>
    </TabBar>

    {#if active.id == 0}
        <Settings/>
    {/if}
    {#if active.id == 1}
        <History />
    {/if}
    {#if active.id == 2}
        <Summary />
    {/if}

</div>
