<script>
    import Dialog, { Content, Actions, Title } from "@smui/dialog";
    import Button, { Label } from "@smui/button";
    import Textfield from "@smui/textfield";
    import { Api } from "./../../../api-access/api.svelte";

    let api = new Api();
    let open = false;
    let data = new Create();

    function save() {
        api.post("settings/accounts/" + data.id, data, function () {
            closeDialog();
            callback();
        });
    }

    function Create(data) {
        let self = this;
        self.id = 0;
        self.name = "";
        self.iban = 0;
        if (data) {
            self.id = data.id;
            self.name = data.name;
            self.iban = data.iban;
        }
    }

    export let callback;

    export function openDialog(id) {
        api.get("settings/accounts/" + id, function (response) {
            data = new Create(response.data);
            open = true;
        });
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
    <Title id="simple-title">Edit</Title>
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
