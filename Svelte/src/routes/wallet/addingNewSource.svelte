<script>
    export let isAddNewOpen;
    import Dialog, { Title, Actions, Content } from "@smui/dialog";
    import Button, { Label, Icon } from "@smui/button";
    import Select, { Option } from "@smui/select";
    import Textfield from "@smui/textfield";
    let sourceTypes = ["Portfel", "Konto"];
    let sourceValue = "";
    let name = "";
    export let saveAction;
    export let closeAction;
</script>

<Dialog
    bind:open={isAddNewOpen}
    aria-labelledby="default-focus-title"
    aria-describedby="default-focus-content"
>
    <Title id="default-focus-title">Żródełko</Title>
    <Content id="default-focus-content">
        <Select bind:sourceValue label="Select Menu">
            {#each sourceTypes as type}
                <Option value={type}>{type}</Option>
            {/each}
        </Select>

        <Textfield bind:value={name} label="Nazwa" />
    </Content>
    <Actions>
        <Button on:click={() => closeAction()}>
            <Label>Close</Label>
        </Button>
        <Button on:click={() => saveAction()}>
            <Label>Save</Label>
        </Button>
    </Actions>
</Dialog>
