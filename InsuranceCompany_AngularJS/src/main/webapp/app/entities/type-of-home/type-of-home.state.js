(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .config(stateConfig);

    stateConfig.$inject = ['$stateProvider'];

    function stateConfig($stateProvider) {
        $stateProvider
        .state('type-of-home', {
            parent: 'entity',
            url: '/type-of-home',
            data: {
                
                pageTitle: 'insuranceFeApp.typeOfHome.home.title'
            },
            views: {
                'content@': {
                    templateUrl: 'app/entities/type-of-home/type-of-homes.html',
                    controller: 'TypeOfHomeController',
                    controllerAs: 'vm'
                }
            },
            resolve: {
                translatePartialLoader: ['$translate', '$translatePartialLoader', function ($translate, $translatePartialLoader) {
                    $translatePartialLoader.addPart('typeOfHome');
                    $translatePartialLoader.addPart('global');
                    return $translate.refresh();
                }]
            }
        })
        .state('type-of-home-detail', {
            parent: 'entity',
            url: '/type-of-home/{id}',
            data: {
                
                pageTitle: 'insuranceFeApp.typeOfHome.detail.title'
            },
            views: {
                'content@': {
                    templateUrl: 'app/entities/type-of-home/type-of-home-detail.html',
                    controller: 'TypeOfHomeDetailController',
                    controllerAs: 'vm'
                }
            },
            resolve: {
                translatePartialLoader: ['$translate', '$translatePartialLoader', function ($translate, $translatePartialLoader) {
                    $translatePartialLoader.addPart('typeOfHome');
                    return $translate.refresh();
                }],
                entity: ['$stateParams', 'TypeOfHome', function($stateParams, TypeOfHome) {
                    return TypeOfHome.get({id : $stateParams.id}).$promise;
                }],
                previousState: ["$state", function ($state) {
                    var currentStateData = {
                        name: $state.current.name || 'type-of-home',
                        params: $state.params,
                        url: $state.href($state.current.name, $state.params)
                    };
                    return currentStateData;
                }]
            }
        })
        .state('type-of-home-detail.edit', {
            parent: 'type-of-home-detail',
            url: '/detail/edit',
            data: {
             
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-home/type-of-home-dialog.html',
                    controller: 'TypeOfHomeDialogController',
                    controllerAs: 'vm',
                    backdrop: 'static',
                    size: 'lg',
                    resolve: {
                        entity: ['TypeOfHome', function(TypeOfHome) {
                            return TypeOfHome.get({id : $stateParams.id}).$promise;
                        }]
                    }
                }).result.then(function() {
                    $state.go('^', {}, { reload: false });
                }, function() {
                    $state.go('^');
                });
            }]
        })
        .state('type-of-home.new', {
            parent: 'type-of-home',
            url: '/new',
            data: {
                
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-home/type-of-home-dialog.html',
                    controller: 'TypeOfHomeDialogController',
                    controllerAs: 'vm',
                    backdrop: 'static',
                    size: 'lg',
                    resolve: {
                        entity: function () {
                            return {
                                name: null,
                                id: null
                            };
                        }
                    }
                }).result.then(function() {
                    $state.go('type-of-home', null, { reload: 'type-of-home' });
                }, function() {
                    $state.go('type-of-home');
                });
            }]
        })
        .state('type-of-home.edit', {
            parent: 'type-of-home',
            url: '/{id}/edit',
            data: {
                
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-home/type-of-home-dialog.html',
                    controller: 'TypeOfHomeDialogController',
                    controllerAs: 'vm',
                    backdrop: 'static',
                    size: 'lg',
                    resolve: {
                        entity: ['TypeOfHome', function(TypeOfHome) {
                            return TypeOfHome.get({id : $stateParams.id}).$promise;
                        }]
                    }
                }).result.then(function() {
                    $state.go('type-of-home', null, { reload: 'type-of-home' });
                }, function() {
                    $state.go('^');
                });
            }]
        })
        .state('type-of-home.delete', {
            parent: 'type-of-home',
            url: '/{id}/delete',
            data: {
            
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-home/type-of-home-delete-dialog.html',
                    controller: 'TypeOfHomeDeleteController',
                    controllerAs: 'vm',
                    size: 'md',
                    resolve: {
                        entity: ['TypeOfHome', function(TypeOfHome) {
                            return TypeOfHome.get({id : $stateParams.id}).$promise;
                        }]
                    }
                }).result.then(function() {
                    $state.go('type-of-home', null, { reload: 'type-of-home' });
                }, function() {
                    $state.go('^');
                });
            }]
        });
    }

})();
