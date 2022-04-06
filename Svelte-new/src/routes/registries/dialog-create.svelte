<script>
    import Dialog, { Content, Actions, Title } from "@smui/dialog";
    import Button, { Label } from "@smui/button";
    import Textfield from "@smui/textfield";
    import { Api } from "./../../api-access/api.svelte";

    let api = new Api();
    let open = false;
    let data = new Create();

    function save() {
        api.put("registry/", data, function () {
            closeDialog();
            callback();
        });
    }

    function Create() {
        let self = this;
        self.id = 0;
        self.from = '';
        self.to = '';
        self.amount = 0;
    }

    export let callback;

    export function openDialog() {
        data = new Create();
        open = true;
    }

    export function closeDialog() {
        open = false;
    }
</script>

<Dialog
    bind:open
    aria-labelledby="slider-title"
    aria-describedby="slider-content"
>
    <Title id="simple-title">New item</Title>
    <Content id="slider-content">
        <Textfield type="date" variant="outlined" bind:value={data.from} label="Name" />
        <Textfield type="date" variant="outlined" bind:value={data.to} label="Name" />
        <Textfield type="number" variant="outlined" bind:value={data.amount} label="Value" />
    </Content>
    <Actions>
        <Button on:click={closeDialog}>
            <Label>Cancel</Label>
        </Button>
        <Button on:click={save} action="accept">
            <Label>Accept</Label>
        </Button>
    </Actions>
</Dialog>
