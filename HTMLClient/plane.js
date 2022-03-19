const URI = "http://www.khoaaa.somee.com/api/planes";


function page_Load() {
    getAll();
}

function lnkID_Click(Id) {
    GetDetails(Id);
}

function btnSearch_Click() {
    var keyword = document.getElementById("txtKeyword").value.trim();
    if (keyword.length > 0) {
        search(keyword);
    } else {
        getAll();
    }
}

function btnAdd_Click() {
    var newPlane = {
        Id: 0,
        Brand: document.getElementById("txtBrand").value,
        Name: document.getElementById("txtName").value,
        Price: document.getElementById("txtPrice").value,
        Size: document.getElementById("txtSize").value
    }
    Add(newPlane);

}

function btnUpdate_Click() {
    var newPlane = {
        Id: document.getElementById("txtId").value,
        Brand: document.getElementById("txtBrand").value,
        Name: document.getElementById("txtName").value,
        Price: document.getElementById("txtPrice").value,
        Size: document.getElementById("txtSize").value

    };
    Update(newPlane);

}

function GetDetails(Id) {
    axios.get(URI + "/" + Id).then((response) => {
        var plane = response.data;
        renderPlaneDetails(plane);
    });
}

function btnDelete_Click() {
    if (confirm("Are you sure?")) {
        var Id = document.getElementById("txtId").value
        deletee(Id);
    }

}

function getAll() {
    axios.get(URI).then((response) => {
        var planes = response.data;
        renderPlaneList(planes);
    });


}





function deletee(Id) {
    axios.delete(URI + "/" + Id).then((response) => {
        var result = response.data;
        if (result) {
            getAll();
            clearTextboxes();
        } else { alert('Please Again! '); }
    });
}



function Update(newPlane) {
    axios.put(URI + "/" + newPlane.Id, newPlane).then((response) => {
        var result = response.data;
        if (result) {
            getAll();
            clearTextboxes();
        } else { alert('Please Again ! '); }
    });

}


function Add(newPlane) {
    axios.post(URI, newPlane).then((response) => {
        var result = response.data;
        if (result) {
            getAll();
            clearTextboxes();
        } else { alert('Please Again'); }
    });
}



function search(keyword) {
    axios.get(URI + "/search/" + keyword).then((response) => {
        var planes = response.data;
        renderPlaneList(planes);

    });
}




function renderPlaneList(planes) {
    var rows = "";
    for (var plane of planes) {
        rows += "<tr onclick='lnkID_Click(" + plane.Id + ")' style='cursor:pointer'>";
        rows += "<td>" + plane.Id + "</td>";
        rows += "<td>" + plane.Brand + "</td>";
        rows += "<td>" + plane.Name + "</td>";
        rows += "<td>" + plane.Price + "</td>";
        rows += "<td>" + plane.Size + "</td>";
        rows += "</tr>";
    }
    var header = "<tr><th>Id</th><th>Brand</th><th>Name</th><th>Price</th><th>Size</th></tr>";
    document.getElementById("dataTable").innerHTML = header + rows;
}


function renderPlaneDetails(plane) {
    document.getElementById("txtId").value = plane.Id;
    document.getElementById("txtBrand").value = plane.Brand;
    document.getElementById("txtName").value = plane.Name;
    document.getElementById("txtPrice").value = plane.Price;
    document.getElementById("txtSize").value = plane.Size;

}

function clearTextboxes() {
    document.getElementById("txtId").value = '';
    document.getElementById("txtBrand").value = '';
    document.getElementById("txtName").value = '';
    document.getElementById("txtPrice").value = '';
    document.getElementById("txtSize").value = '';
}