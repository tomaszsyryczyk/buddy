import React from 'react';
import './Button.css';

class Button extends React.Component{
    render(){
        
        var onClick = this.props.onClick;
        var text = this.props.text;
        debugger;
        return (
            <div className="Button">
                <button onClick={onClick} value={text} />        
            </div>
        );
    }
}

export default Button;