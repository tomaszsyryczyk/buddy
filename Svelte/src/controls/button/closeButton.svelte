<script>
    export let click;
    export let icon;
    import Button from "./button.svelte";
</script>

<div class="button">
    <Button {icon} {click} />
</div>

<style>
.button {
    position: absolute;
    top: 0;
    right: 25px;
    font-size: 36px;
    margin-left: 50px;
}
</style>
