# check props.
public componentDidUpdate(prevProps) {
    if (prevProps.ruleDefId !== this.props.ruleDefId) {
        this.getAppendSettingsContent();
    }
}

