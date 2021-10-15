<script>
    import Button from "./../button/button.svelte";
    export let isOpen;
    $: className = isOpen? "show" : "hidden";

    function toggleModal(){
        isOpen = false;
    }

    function closeModal(){
        var shadow = document.getElementById("shadow");
        if(event.target === shadow)
            toggleModal();
    }
</script>


<div id="shadow" class="shadow {className}" on:click="{closeModal}">
    <div class="modal">
        <div class="row end-xs header">
            <div>
                <Button icon="far fa-times-circle" click="{toggleModal}"/>
            </div>
        </div>
    
        <div class="content">
        <slot>
            
        </slot>
        </div>
        <div class="footer">
    
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
    transition: visibility 0s linear 0.25s, opacity 0.25s 0s, transform 0.25s;
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
}

.footer {
    border-radius: 0 0 0.5rem 0.5rem;    
    padding: 1rem 1.5rem;
    min-height: 1em;
    background-color: #393939;
}

.header{
    border-radius: 0.5rem 0.5rem 0 0;  
    min-height: 1em;
    background-color: #393939;
    margin: 0;
}

.show { 
    opacity: 1;
        visibility: visible;
        transform: scale(1.0);
        transition: visibility 0s linear 0s, opacity 0.25s 0s, transform 0.25s;
}

.hide {    
    /* display: none; */
}



</style>

