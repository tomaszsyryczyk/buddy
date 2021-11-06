<script>
    import CloseButton from "../button/close-button.svelte";
    import Button from "./../button/button.svelte";
    export let isOpen;
    export let success;
    $: className = isOpen ? "show" : "hidden";

    function toggleModal() {
        isOpen = !isOpen;
    }

    function closeModal() {
        console.log("close modal");
        var shadow = document.getElementById("shadow");
        if (event.target === shadow) toggleModal();
        event.stopPropagation();
    }
</script>

<div id="shadow" class="shadow {className}" on:mousedown={closeModal}>
    <div id="modal" class="modal">
        <div class="row end-xs header">
            <div>
                <CloseButton icon="fas fa-times-circle" click={toggleModal} />
            </div>
        </div>

        <div class="row content">
            <slot />
        </div>
        <div class="row end-xs footer">
            <div>
                <Button text="Save" icon="fas fa-check" click={success} />
            </div>
        </div>
    </div>
</div>

<style>
    .shadow {
        position: fixed;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        background-color: rgba(0, 0, 0, 0.5);
        opacity: 0;
        visibility: hidden;
        transform: scale(1.1);
        transition: visibility 0s linear 0.25s, opacity 0.25s 0s,
            transform 0.25s;
    }

    .modal {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        background-color: transparent;
        width: 24rem;
    }

    .content {
        background-color: #222;
        margin: 0;
    }

    .footer {
        border-radius: 0 0 0.5rem 0.5rem;
        padding: 0.5rem;
        min-height: 1em;
        background-color: #393939;
        margin: 0;
    }

    .header {
        padding: 0.5rem;
        border-radius: 0.5rem 0.5rem 0 0;
        min-height: 1em;
        background-color: #393939;
        margin: 0;
    }

    .show {
        opacity: 1;
        visibility: visible;
        transform: scale(1);
        transition: visibility 0s linear 0s, opacity 0.25s 0s, transform 0.25s;
    }
</style>
