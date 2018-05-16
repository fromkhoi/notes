if (filter.CreateStatus != null && filter.CreateStatus.Count() > 0)
{
    var previewStatusSelected = filter.CreateStatus.Where(q => q.Selected == true).Select(q => q.Value);
    if (previewStatusSelected.Count() > 0)
    {
        imagePreviews = imagePreviews.Where(q => previewStatusSelected.Contains(q.CreateStatus.ToCustomStringValue()));
    }
}