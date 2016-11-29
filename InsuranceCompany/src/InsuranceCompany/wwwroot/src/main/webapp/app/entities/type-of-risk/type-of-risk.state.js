(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .config(stateConfig);

    stateConfig.$inject = ['$stateProvider'];

    function stateConfig($stateProvider) {
        $stateProvider
        .state('type-of-risk', {
            parent: 'entity',
            url: '/type-of-risk',
            data: {
               
                pageTitle: 'insuranceFeApp.typeOfRisk.home.title'
            },
            views: {
                'content@': {
                    templateUrl: 'app/entities/type-of-risk/type-of-risks.html',
                    controller: 'TypeOfRiskController',
                    controllerAs: 'vm'
                }
            },
            resolve: {
                translatePartialLoader: ['$translate', '$translatePartialLoader', function ($translate, $translatePartialLoader) {
                    $translatePartialLoader.addPart('typeOfRisk');
                    $translatePartialLoader.addPart('global');
                    return $translate.refresh();
                }]
            }
        })
        .state('type-of-risk-detail', {
            parent: 'entity',
            url: '/type-of-risk/{id}',
            data: {
               
                pageTitle: 'insuranceFeApp.typeOfRisk.detail.title'
            },
            views: {
                'content@': {
                    templateUrl: 'app/entities/type-of-risk/type-of-risk-detail.html',
                    controller: 'TypeOfRiskDetailController',
                    controllerAs: 'vm'
                }
            },
            resolve: {
                translatePartialLoader: ['$translate', '$translatePartialLoader', function ($translate, $translatePartialLoader) {
                    $translatePartialLoader.addPart('typeOfRisk');
                    return $translate.refresh();
                }],
                entity: ['$stateParams', 'TypeOfRisk', function($stateParams, TypeOfRisk) {
                    return TypeOfRisk.get({id : $stateParams.id}).$promise;
                }],
                previousState: ["$state", function ($state) {
                    var currentStateData = {
                        name: $state.current.name || 'type-of-risk',
                        params: $state.params,
                        url: $state.href($state.current.name, $state.params)
                    };
                    return currentStateData;
                }]
            }
        })
        .state('type-of-risk-detail.edit', {
            parent: 'type-of-risk-detail',
            url: '/detail/edit',
            data: {
               
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-risk/type-of-risk-dialog.html',
                    controller: 'TypeOfRiskDialogController',
                    controllerAs: 'vm',
                    backdrop: 'static',
                    size: 'lg',
                    resolve: {
                        entity: ['TypeOfRisk', function(TypeOfRisk) {
                            return TypeOfRisk.get({id : $stateParams.id}).$promise;
                        }]
                    }
                }).result.then(function() {
                    $state.go('^', {}, { reload: false });
                }, function() {
                    $state.go('^');
                });
            }]
        })
        .state('type-of-risk.new', {
            parent: 'type-of-risk',
            url: '/new',
            data: {
                
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-risk/type-of-risk-dialog.html',
                    controller: 'TypeOfRiskDialogController',
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
                    $state.go('type-of-risk', null, { reload: 'type-of-risk' });
                }, function() {
                    $state.go('type-of-risk');
                });
            }]
        })
        .state('type-of-risk.edit', {
            parent: 'type-of-risk',
            url: '/{id}/edit',
            data: {
                
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-risk/type-of-risk-dialog.html',
                    controller: 'TypeOfRiskDialogController',
                    controllerAs: 'vm',
                    backdrop: 'static',
                    size: 'lg',
                    resolve: {
                        entity: ['TypeOfRisk', function(TypeOfRisk) {
                            return TypeOfRisk.get({id : $stateParams.id}).$promise;
                        }]
                    }
                }).result.then(function() {
                    $state.go('type-of-risk', null, { reload: 'type-of-risk' });
                }, function() {
                    $state.go('^');
                });
            }]
        })
        .state('type-of-risk.delete', {
            parent: 'type-of-risk',
            url: '/{id}/delete',
            data: {
               
            },
            onEnter: ['$stateParams', '$state', '$uibModal', function($stateParams, $state, $uibModal) {
                $uibModal.open({
                    templateUrl: 'app/entities/type-of-risk/type-of-risk-delete-dialog.html',
                    controller: 'TypeOfRiskDeleteController',
                    controllerAs: 'vm',
                    size: 'md',
                    resolve: {
                        entity: ['TypeOfRisk', function(TypeOfRisk) {
                            return TypeOfRisk.get({id : $stateParams.id}).$promise;
                        }]
                    }
                }).result.then(function() {
                    $state.go('type-of-risk', null, { reload: 'type-of-risk' });
                }, function() {
                    $state.go('^');
                });
            }]
        });
    }

})();
