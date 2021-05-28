const uri = 'api/BusModels';
let busmodels = [];

function getBusModel() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayBusModel(data))
        .catch(error => console.error('Unable to get bus models.', error));
}

function addBusModel() {
    const addNameTextbox = document.getElementById('add-name');
    //const addInfoTextbox = document.getElementById('add-info');

    const busmodel = {
        name: addNameTextbox.value.trim(),
       // info: addInfoTextbox.value.trim(),
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(busmodel)
    })
        .then(response => response.json())
        .then(() => {
            getBusModel();
            addNameTextbox.value = '';
            //addInfoTextbox.value = '';
        })
        .catch(error => console.error('Unable to add bus model.', error));
}

function deleteBusModel(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getBusModel())
        .catch(error => console.error('Unable to delete bus model.', error));
}

function displayEditForm(id) {
    const busmodel = busmodels.find(busmodel => busmodel.id === id);

    document.getElementById('edit-id').value = busmodel.id;
    document.getElementById('edit-name').value = busmodel.name;
    //document.getElementById('edit-info').value = category.info;
    document.getElementById('editForm').style.display = 'block';
}

function updateBusModel() {
    const busmodelId = document.getElementById('edit-id').value;
    const busmodel = {
        id: parseInt(busmodelId, 10),
        name: document.getElementById('edit-name').value.trim()
        //info: document.getElementById('edit-info').value.trim()
    };

    fetch(`${uri}/${busmodelId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(busmodel)
    })
        .then(() => getBusModel())
        .catch(error => console.error('Unable to update bus model.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}


function _displayBusModel(data) {
    const tBody = document.getElementById('busmodels');
    tBody.innerHTML = '';


    const button = document.createElement('button');

    data.forEach(busmodel => {
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${busmodel.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteBusModel(${busmodel.id})`);

        let tr = tBody.insertRow();


        let td1 = tr.insertCell(0);
        let textNode = document.createTextNode(busmodel.name);
        td1.appendChild(textNode);

        /*let td2 = tr.insertCell(1);
        let textNodeInfo = document.createTextNode(category.info);
        td2.appendChild(textNodeInfo);*/

        let td3 = tr.insertCell(1);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(2);
        td4.appendChild(deleteButton);
    });

    busmodels = data;
}
