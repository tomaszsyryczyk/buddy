<script>
    export let value;
    export let currencyUnit;
    export let isPositive = true;
    $: className = isPositive ? "positive" : "negative";

    function getValue() {
        let string = new String(value);
        string = string.replace("/^-+/", "");
        if (isPositive) return string;
        return "- " + string;
    }
</script>

<p class={className}>
    {getValue()}
    {currencyUnit}
</p>

<style>
    .positive {
        color: green;
    }

    .negative {
        color: red;
    }
</style>
