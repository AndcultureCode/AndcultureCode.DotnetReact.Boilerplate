import {
    Button,
    ButtonSizes,
    ButtonStyles,
} from "andculturecode-javascript-react-components";
import Faker from "faker";
import AccessibleList from "molecules/accessible-list/accessible-list";
import React from "react";

export default {
    title: "Molecules | Accessible List / Accessible List",
    component: AccessibleList,
};

export const accessibleListDefault = () => (
    <AccessibleList focusFirstItem={true}>
        <Button style={ButtonStyles.Primary} size={ButtonSizes.Medium}>
            {Faker.lorem.words(5)}
        </Button>
    </AccessibleList>
);