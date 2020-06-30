import Button from "atoms/buttons/button";
import { ButtonStyles } from "atoms/constants/button-styles";
import ButtonGroup from "organisms/button-groups/button-group";
import React from "react";

export default {
    title: "Organisms | Button Groups / Button Group",
    component: ButtonGroup,
};

export const buttonGroupDefault = () => (
    <ButtonGroup>
        <Button style={ButtonStyles.TertiaryAlt}>Button 1</Button>
        <Button style={ButtonStyles.TertiaryAlt}>Button 2</Button>
        <Button style={ButtonStyles.TertiaryAlt}>Button 3</Button>
        <Button style={ButtonStyles.TertiaryAlt}>Button 4</Button>
    </ButtonGroup>
);