import React from "react";
import Stock from "./Stock";
import Button from "./../../Controls/Button/Button";
import "./Stocks.css";
import Modal from "../../Controls/Button/Modal/Modal";


class Stocks extends React.Component {
    constructor(props) {
        super(props);
    
        this.state = { isOpen: false };
    }

    render(){
        return (
            <div className="Stocks">
                <Button text="Add stock" onClick={this.toggleModal}></Button>
                    <Stock name="CDPR" count="5" price="172,5" fee="5" />
                    <Stock name="KGHM" count="5" price="172,5" fee="5" />
                    <Stock name="PKOBP" count="30" price="172,5" fee="5" />
                    <Stock name="PZU" count="36" price="172,5" fee="5" />
                    <Modal show={this.state.isOpen}
                        onClose={this.toggleModal}>
                        Here's some content for the modal
                    </Modal>                
            </div>
        );
    }

    toggleModal = () => {
        this.setState({
          isOpen: !this.state.isOpen
        });
      }
    
}

function onClickHere(){
    debugger;
};

Stocks.propTypes = {

}

export default Stocks;