<script>
    import Dialog, { Content, Actions, Title } from "@smui/dialog";
    import Button, { Label } from "@smui/button";
    import Textfield from "@smui/textfield";
    import { Api } from "./../../api-access/api.svelte";

    let api = new Api();
    let open = false;
    let data = new Create();

    function save() {
        api.delete("registry/" + data.id, null, function () {
            closeDialog();
            callback();
        });
    }

    function Create(data) {
        let self = this;
        self.id = 0;
        self.from = '';
        self.to = '';
        self.amount = 0;
        if (data) {
            self.id = data.id;
            self.from = data.from;
            self.to = data.to;
            self.amount = data.amount;
        }
    }

    export let callback;

    export function openDialog(id) {
        api.get("registry/" + id, function (response) {
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
    <Title id="simple-title">Are you sure you want to remove it?</Title>
    <Content id="slider-content">
        <Textfield disabled type="date" variant="outlined" bind:value={data.from} label="Name" />
        <Textfield disabled type="date" variant="outlined" bind:value={data.to} label="Name" />
        <Textfield disabled type="number" variant="outlined" bind:value={data.amount} label="Value" />
    </Content>
    <Actions>
        <Button on:click={closeDialog}>
            <Label>Cancel</Label>
        </Button>
        <Button on:click={save} action="accept">
            <Label>Delete</Label>
        </Button>
    </Actions>
</Dialog>
