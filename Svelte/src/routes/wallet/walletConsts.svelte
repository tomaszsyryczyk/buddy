<script context="module">    
    import {enumType} from "./../../controls/input/inputEnum.svelte";

    export function getWalletEntryTypes() {
        var enumTypes = [
            new enumType("Income", 1),
            new enumType("Expenses", 0),
            new enumType("Taxes", 2),
        ];
        return enumTypes;
    }
</script>
