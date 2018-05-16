private ISession _session;

/// <summary>
/// Constructor
/// </summary>
public SystemLogsController(IHttpContextAccessor httpContextAccessor)
{
    this._session = httpContextAccessor.HttpContext.Session;
}

private void SaveFilterViewModelToSession(FilterViewModel model)
{
    this.SessionFilterViewModel = model;
}

private FilterViewModel SessionFilterViewModel
{
    get { return Serializer.FromJson<FilterViewModel>(this._session.GetString("JobPackageLogController.FilterViewModel")); }
    set { this._session.SetString("JobPackageLogController.FilterViewModel", Serializer.ToJson(value)); }
}

/// call save
this.SaveFilterViewModelToSession(viewmodel.Filter);

// get model
this.SessionFilterViewModel;
