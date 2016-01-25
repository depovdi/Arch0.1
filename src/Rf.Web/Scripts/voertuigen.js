$(function () {
    function GetCars() {
        var carsJSON = $('#voertuigenData').val();
        var carsParsed = ko.utils.parseJson(carsJSON);

        var mappedCars = ko.utils.arrayMap(carsParsed, function (car) {
            return new Car(car.Id, car.Soort, car.NummerPlaat, car.Merk);
        });

        return mappedCars;
    }

    var Car = function (id, kind, plateNr, brand) {
        this.id = id;
        this.kind = kind;
        this.plateNr = plateNr;
        this.brand = brand;
    }

    var carsViewModel = {
        cars: ko.observableArray(GetCars()),
        carsFiltered: ko.observableArray(),
        kinds: ko.observableArray(),
        selectedKind: ko.observable(),
    }

    var filterCars = function (soort) {
        carsViewModel.carsFiltered(ko.utils.arrayFilter(carsViewModel.cars(), function (item) {
            return item.kind == soort;
        }));
    };

    carsViewModel.selectedKind.subscribe(function (newValue) {
        filterCars(newValue);
    });

    ko.utils.arrayForEach(carsViewModel.cars(), function (item) {
        carsViewModel.kinds.push(item.kind);
        carsViewModel.kinds.push(item.kind);
    });

    carsViewModel.kinds(ko.utils.arrayGetDistinctValues(carsViewModel.kinds()));

    filterCars(carsViewModel.kinds()[0]);

    ko.applyBindings(carsViewModel);
});