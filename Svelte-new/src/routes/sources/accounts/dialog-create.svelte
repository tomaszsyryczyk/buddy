<script>
    import Dialog, { Content, Actions, Title } from "@smui/dialog";
    import Button, { Label } from "@smui/button";
    import Textfield from "@smui/textfield";
    import { Api } from "./../../../api-access/api.svelte";

    let api = new Api();
    let open = false;
    let data = new Create();

    function save() {
        api.put("settings/accounts/", data, function () {
            closeDialog();
            callback();
        });
    }

    function Create() {
        let self = this;
        self.name = "";
        self.iban = 0;
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
        <Textfield variant="outlined" bind:value={data.name} label="Name" />
        <Textfield variant="outlined" bind:value={data.iban} label="Value" />
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
