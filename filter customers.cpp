Customer* filterCustomers(char filterBy, char info[20], int* length, int type) {
	List filtered_list;

	/*
	filterby: 'S' = status, 'C' = course.
	info[]: status / course to fliter by.
	*/
	type = 1;
	if (filterBy == 'S') {
		List &temp_list = global_list;
		Status filter_status;
		std::string filter_str = info;
		if (filter_str == "new_lead") {
			filter_status = new_lead;
			type = 0;
		}
		if (filter_str == "call_later") filter_status = call_later;
		if (filter_str == "send_email") filter_status = send_email;
		if (filter_str == "success") filter_status = success;
		if (filter_str == "irrelevent") filter_status = irrelevent;


		for (int i = 0; i < global_list.size; i++) {
			Customer *customer = ExtractFromList(temp_list, i)->customer;
			if (customer->status == filter_status) {
				AddToList(filtered_list, *customer);
			}
		}

		return listToArray(filtered_list, length);
	}
	else if (filterBy == 'C') {

		for (int i = 0; i < global_list.size; i++) {
			//work in progress.
		}
	}
	return NULL;
}