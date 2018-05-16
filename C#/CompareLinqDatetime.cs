order.Where(q => DateTime.Compare(DateTime.Now.Date, q.DeliveryDueDate.Value.Date) >= 0);

// lấy orders có ngày deliveryduedate từ trước ngày hiện tại đến giờ.