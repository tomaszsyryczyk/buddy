<script>
    import { onMount } from "svelte";
    import Button from "./../../controls/button/button.svelte";
    import AddEntryModal from "./addEntryModal.svelte";
    import Table, { column } from "./../../controls/table/table.svelte";
    import {getWalletEntryTypes} from "./walletConsts.svelte";

    let isAddEntryModalOpen = false;

    onMount(async () => {
        axios({
            method: "get",
            headers: { "content-type": "application/json" },
            url: "https://localhost:5001/api/wallet/all",
            data: {
                request: undefined,
            },
        }).then(function (response) {
            balance = response.data.balance;
            entries = response.data.entries;
        });
    });

    function addEntryModalOpen() {
        isAddEntryModalOpen = !isAddEntryModalOpen;
    }

    let entries = [];
    let balance = 0;

    var enumTypes = getWalletEntryTypes();
    function mappers() {
        return [
            new column("Data", (row) => row.when),
            new column("Typ", (row) => {
                let find = enumTypes.find(x => x.value == row.type);
                return find.name;
            }),
            new column("Nazwa", (row) => row.name),
            new column("Wartość", (row) => row.value),
            new column("Balans", (row) => row.balance),
        ];
    }

</script>

<Button click={addEntryModalOpen} icon="fa fa-plus" />

<AddEntryModal bind:modalOpen={isAddEntryModalOpen} />

<Table rows={entries} rowMappers={mappers()} />

<style>
</style>
